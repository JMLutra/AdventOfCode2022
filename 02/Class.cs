namespace AoC.Second
{
    class Class
    {
        public Class()
        {
            var input = File.ReadAllLines("files/02.txt");
            int score = 0;
            for(int i = 0; i < input.Length; i++)
            {
                var chars = input[i].ToCharArray();
                switch(chars[0])
                {
                    case 'A':
                        switch(chars[2])
                        {
                            case 'X':
                                score += 4;
                                break;

                            case 'Y':
                                score += 8;
                                break;

                            case 'Z':
                                score += 3;
                                break;
                            
                            default:
                                break;
                        }
                        break;

                    case 'B':
                        switch(chars[2])
                        {
                            case 'X':
                                score += 1;
                                break;

                            case 'Y':
                                score += 5;
                                break;

                            case 'Z':
                                score += 9;
                                break;
                            
                            default:
                                break;
                        }
                        break;

                    case 'C':
                        switch(chars[2])
                        {
                            case 'X':
                                score += 7;
                                break;

                            case 'Y':
                                score += 2;
                                break;

                            case 'Z':
                                score += 6;
                                break;
                            
                            default:
                                break;
                        }
                        break;
                    
                    default:
                        break;
                }
            }
        
            Console.WriteLine(score);
        }
    }
}