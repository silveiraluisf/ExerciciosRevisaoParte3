namespace Cliente.model
{
    public class Client
    {
        private string _name;
        private long _cpf;
        private DateTime _bornDate;
        private float _income;
        private char _status;
        private int _n;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public long CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        public DateTime BirthDate
        {
            get { return _bornDate; }
            set { _bornDate = value; }
        }
        public float MonthlyIncome
        {
            get { return _income; }
            set { _income = value; }
        }
        public char MaritalStatus
        {
            get { return _status; }
            set { _status = value; }
        }
        public int NumberOfDependents
        {
            get { return _n; }
            set { _n = value; }
        }

    }
}
