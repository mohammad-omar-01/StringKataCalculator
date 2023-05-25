namespace StringKataCalculator.logic
{
    public class Calculator
    {
       public Calculator() { }

        public  int Add(string data)
        {
            if (data.Length == 0) return 0;
            if (data.Length == 1) return int.Parse(data);
            var list=getNumbers(data);
            if (list.Any(x => x < 0)) {
                throw new InvalidDataException($"negatives not allowed: {String.Join(",", (from n in list.Where(x=>x<0) select n.ToString()).ToArray())}");
            }
            return list.Sum();

        }
        private List<int> getNumbers(string data) { 
        List<int> list = new List<int>();
            char[] delimiterChars = { ',', '\n'};
            foreach (string item in data.Split(delimiterChars))
            {
                int number;
                bool isSuccessParsed = int.TryParse(item,out number);
                if (isSuccessParsed) 
                list.Add(number);
                    
            }
        
        return list;
        }
    }
}
