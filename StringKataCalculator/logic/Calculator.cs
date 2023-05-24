namespace StringKataCalculator.logic
{
    public class Calculator
    {
       public Calculator() { }

        public  int Add(string data)
        {
            if (data.Length == 0) return 0;
            if (data.Length == 1) return int.Parse(data);
            int sum = (int) char.GetNumericValue(data[0]) + (int)char.GetNumericValue(data[1]);
            return sum;

        }
    }
}
