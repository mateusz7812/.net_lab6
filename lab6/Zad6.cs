public static class Zad6{
    public static (int, int, int, int) CountMyTypes(params object[] args){
        int evens = 0, realPositives = 0, strings = 0, others = 0;
        foreach (var item in args)
        {
            switch (item)
            {
                case int i:
                    if (i % 2 == 0)
                        evens++;
                    break;
                case double d:
                    if (d > 0)
                        realPositives ++;
                    break;
                case string s:
                    if (s.Length >= 5)
                        strings ++;
                    break;
                default:
                    others ++;
                    break;
            }
        }
        return (evens, realPositives, strings, others);
    }
}