namespace WindowsFormsPhotoDirComparer
{
    class Picture
    {
        public Picture(string name, long length)
        {
            Name = name;
            Length = length;
        }
        public string Name { get; private set; }
        public long Length { get; private set; }

        public override bool Equals(object obj)
        {
            Picture other = obj as Picture;
            if (other == null)
            {
                return base.Equals(obj);
            }

            return Length.Equals(other.Length);
        }

        public override int GetHashCode()
        {
            return (int)(Length / 2);
        }

        public override string ToString()
        {
            return string.Format("{0} size:{1}\r\n", Name, Length);
        }
    }
}
