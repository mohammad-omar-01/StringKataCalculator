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
