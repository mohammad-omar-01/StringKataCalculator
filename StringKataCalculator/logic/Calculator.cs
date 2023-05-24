namespace StringKataCalculator.logic
{
    public class Calculator
    {
       public Calculator() { }

        public  int Add(string data)
        {
            if (data == null) return 0;
            if (data.Length == 1) return int.Parse(data);
            return 0;
        }
    }
}
