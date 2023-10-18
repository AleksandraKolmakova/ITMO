namespace WebMVCR1.Model
{
     public class ModelClass 
        { public static string ModelHello() 
            { 
                int hour = DateTime.Now.Hour; 
                string Greeting = hour < 12 ? "Доброе утро" : "Добрый день"; 
                return Greeting; 
            } 
        }
    
}
