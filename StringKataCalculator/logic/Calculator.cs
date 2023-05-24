namespace StringKataCalculator.logic
{
    public class Calculator
    {
       public Calculator() { }

        public  int Add(string data)
        {
            if (data.Length == 0) return 0;
            if (data.Length == 1) return int.Parse(data);

            return data.Where(x=> char.IsNumber(x)).Sum(x=>(int)char.GetNumericValue(x));

        }
    }
}
