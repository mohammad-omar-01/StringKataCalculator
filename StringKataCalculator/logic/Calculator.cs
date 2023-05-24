namespace StringKataCalculator.logic
{
    public class Calculator
    {
       public Calculator() { }

        public  int Add(string data)
        {
            if (data.Length == 0) return 0;
            if (data.Length == 1) return int.Parse(data);
            var list=data.Split(',');

            return list.Sum(x=>int.Parse(x));

        }
    }
}
