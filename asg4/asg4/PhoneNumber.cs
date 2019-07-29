namespace asg4
{
    public class PhoneNumber
    {
        private string name;
        private string phone;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Phone
        {
            get => phone;
            set => phone = value;
        }
        
        public PhoneNumber(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
    }
}