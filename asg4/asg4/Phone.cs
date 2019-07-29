namespace asg4
{
    public abstract class Phone
    {
        public abstract void insertPhone(string name, string phone);
        public abstract void DeletePhone(string name);
        public abstract void UpdatePhone(string name, string NewPhone);
        public abstract void SearchPhone(string name);
    }
}