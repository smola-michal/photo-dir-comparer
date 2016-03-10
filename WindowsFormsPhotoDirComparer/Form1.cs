using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsPhotoDirComparer
{
    public partial class Form1 : Form
    {
        private string[] Extensions = new[] { "jpg" };
        List<Picture> _picturesLeft;
        List<Picture> _picturesRight;

        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openDialog = new FolderBrowserDialog())
            {
                openDialog.RootFolder = Environment.SpecialFolder.MyPictures;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    if (sender.Equals(buttonBrowse1))
                    {
                        _textPathLeft.Text = openDialog.SelectedPath;
                        if (string.IsNullOrEmpty(_textPathRight.Text))
                        {
                            _textPathRight.Text = openDialog.SelectedPath;
                        }
                    }
                    else
                    {
                        _textPathRight.Text = openDialog.SelectedPath;
                    }
                }
            }
        }

        private void LoadLeftClick(object sender, EventArgs e)
        {
            LoadLeft();
        }

        private void LoadLeft()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            _picturesLeft = CollectPictures(_textPathLeft.Text);
            stopWatch.Stop();
            _labelLoadTimeLeft.Text = stopWatch.Elapsed.ToString(@"mm\:ss\:fff");
        }

        private void LoadRightClick(object sender, EventArgs e)
        {
            LoadRight();
        }

        private void LoadRight()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            _picturesRight = CollectPictures(_textPathRight.Text);
            stopWatch.Stop();
            _labelLoadTimeRight.Text = stopWatch.Elapsed.ToString(@"mm\:ss\:fff");
        }

        private void GoClick(object sender, EventArgs e)
        {
            if(_picturesLeft == null)
            {
                LoadLeft();
            }

            if(_picturesRight == null)
            {
                LoadRight();
            }

            if (_picturesLeft != null && _picturesRight != null)
            {
                Tuple<List<Picture>, List<Picture>> results = _radioDuplicates.Checked ? FindDuplicates(_picturesLeft, _picturesRight) : FindOriginals(_picturesLeft, _picturesRight);
                ShowResults(results);
            }
        }

        private void ShowResults(Tuple<List<Picture>, List<Picture>> results)
        {
            _textResultLeft.Clear();
            _textResultRight.Clear();

            foreach (Picture result in results.Item1)
            {
                _textResultLeft.AppendText(string.Format("{0} size:{1}\r\n", result.Name, result.Length));
            }

            foreach (Picture result in results.Item2)
            {
                _textResultRight.AppendText(string.Format("{0} size:{1}\r\n", result.Name, result.Length));
            }
        }

        private List<Picture> CollectPictures(string path)
        {
            List<Picture> result = new List<Picture>();
            if (Directory.Exists(path))
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    foreach (var extension in Extensions)
                    {
                        foreach (var picture in Directory.EnumerateFiles(path, $"*.{extension}", SearchOption.AllDirectories))
                        {
                            var info = new FileInfo(picture);
                            result.Add(new Picture(info.FullName, info.Length));
                        }
                    }
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            
            return result;
        }

        private Tuple<List<Picture>, List<Picture>> FindOriginals(List<Picture> leftPictures, List<Picture> rightPictures)
        {
            Tuple<List<Picture>, List<Picture>> originals = new Tuple<List<Picture>, List<Picture>>(new List<Picture>(), new List<Picture>());
            foreach (var leftPicture in leftPictures)
            {
                Picture foundRightPicture = null;
                foreach (var rightPicture in rightPictures)
                {
                    if (leftPicture.Equals(rightPicture))
                    {
                        foundRightPicture = rightPicture;
                    }
                }
                if (foundRightPicture == null)
                {
                    originals.Item1.Add(leftPicture);
                }
                else
                {
                    rightPictures.Remove(foundRightPicture);
                }
            }
            foreach(var rightPicture in rightPictures)
            {
                originals.Item2.Add(rightPicture);
            }
            return originals;
        }

        private Tuple<List<Picture>, List<Picture>> FindDuplicates(List<Picture> leftPictures, List<Picture> rightPictures)
        {
            Tuple<List<Picture>, List<Picture>> duplicates = new Tuple<List<Picture>, List<Picture>>(new List<Picture>(), new List<Picture>());
            foreach (var pictureLeft in leftPictures)
            {
                foreach (var pictureRight in rightPictures)
                {
                    if (pictureLeft.Equals(pictureRight))
                    {
                        duplicates.Item1.Add(pictureLeft);
                        duplicates.Item2.Add(pictureRight);
                    }
                }
            }
            return duplicates;
        }

        private void SaveLeft_Click(object sender, EventArgs e)
        {

        }

        private void SaveRight(object sender, EventArgs e)
        {

        }

        private void CopyToRightClick(object sender, EventArgs e)
        {
            foreach(var picture in _picturesLeft)
            {
                Copy(picture.Name, _textPathLeft.Text, _textPathRight.Text);
            }
        }

        private void CopyToLeftClick(object sender, EventArgs e)
        {
            foreach(var picture in _picturesRight)
            {
                Copy(picture.Name, _textPathRight.Text, _textPathLeft.Text);
            }
        }

        private void Copy(string fileName, string sourceFolder, string destinationFolder)
        {
            if(!Directory.Exists(destinationFolder) || !File.Exists(fileName))
            {
                Debug.Fail("Destination directory or file does not exists");
                return;
            }
            
            destinationFolder = Path.Combine(destinationFolder, GetSubfolder(fileName, sourceFolder));
            if(!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }
            
            File.Copy(fileName, Path.Combine(destinationFolder, Path.GetFileName(fileName)), false);
        }

        private string GetSubfolder(string fileName, string sourceFolder)
        {
            string shortFileName = Path.GetFileName(fileName);
            string subfolderWithFileName = fileName.Substring(sourceFolder.Length);
            string result = subfolderWithFileName.Substring(0, subfolderWithFileName.Length - shortFileName.Length);
            return result.TrimStart('\\').TrimEnd('\\');
        }
    }
}
