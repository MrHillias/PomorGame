using PomorGame.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomorGame
{
    public class EasyQuestions
    {
        public List<Question> questions;
       
        public EasyQuestions() {
           questions = new List<Question>();
            questions.Add(new Question("Как у поморов назывался предмет для сбора лесных ягод?", "Грабилка", "Клещица", 
                "Короб", "Ранец", "Грабилка", true, new List<Bitmap> { Resources.Grabilka }));
            questions.Add(new Question("Что из нижеперечисленного остаток рыболовной сети, который использовался как тряпки для вытирания рук?",
                "Рукотерток", "Струсни", "Туес", "Плошка", "Рукотерток", true, new List<Bitmap> { Resources.Rukotertok}));
            questions.Add(new Question("Какой предмет использовали для вычерпывания воды из лодки при течи?", "Плица",
                "Чугунок", "Латка", "Ведро", "Плица", true, new List<Bitmap> { Resources.Plitza }));
            questions.Add(new Question("Как называется обувь промысловиков из кожи морского зверя?", "Бродаги", "Боты", 
                "Крошни", "Калоши", "Бродаги", true, new List<Bitmap> { Resources.Brodagi }));
            questions.Add(new Question("У поморов этот предмет использовался для приготовления пищи в печи с высокой температурой?", 
                "Чугунок", "Латка", "Рубель", "Сундук", "Чугунок", false, new List<Bitmap> { Resources.Chugunok, Resources.Latka, Resources.Rubel, Resources.Sunduk}));
            questions.Add(new Question("Как поморы называли тарелку или миску?", "Плошка", "Плица", "Сечка", 
                "Латка", "Плошка", true, new List<Bitmap> { Resources.Ploshka }));
            questions.Add(new Question("Как назывались место лова, участок берега, где могли располагаться рыбацкая избушка, амбар, ставились снасти для лова рыбы?",
                "Тоня", "Невод", "Кибас", "Луда", "Тоня", true, new List<Bitmap> { Resources.Tonya }));
            questions.Add(new Question("Как зовется хозяйка дома в поморской семье?", "Большуха", "Домуха", "Хозяюшка", 
                "Главнуха", "Большуха", true, new List<Bitmap> { Resources.Bolshuha }));
        }
    }
}
