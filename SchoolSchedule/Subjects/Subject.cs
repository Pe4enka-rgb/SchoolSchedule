using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSchedule.Subjects {

    public class Subject {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public Subject() { }
        public Subject(string name) {
            this.name = name;
        }
    }

    /*
    Математика
    Алгебра        
    Геометрия       
    Физика          
    Химия           
    Информатика и ИКТ

    Окружающий мир  
    География       
    Биология        
    Обществознание  
    Литература      
    История         
    ОБЖ            
    Технология     
    Физ-ра          
    Музыка          
    ИЗО             
    МХК             

    Русский язык    
    Английский язык 
    Немецкий язык   
    Иностранный язык
    */

}
