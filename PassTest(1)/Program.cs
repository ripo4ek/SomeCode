using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace IMJunior
{
    class Program
    {

        static void Main(string[] args)
        {
            var array = new Stage[]
            {
                new Stage(new Question("Кто вы?"),new Answer[]
                {
                    new Answer("Человек"),
                    new Answer("Брандлмуха"),
                    new Answer("Кхаджит"),
                } ),
                new Stage(new Question("Что вы хотите?"), new Answer[]
                {
                    new Answer("Победить Аразота"),
                    new Answer("Стать богатым"),
                    new Answer("Найти боевых товарищей"),
                }),
                new Stage(new Question("Чем вы можете помочь ордену?"), new Answer[]
                {
                    new Answer("Я отлчиный воин"),
                    new Answer("Я добротный маг"),
                    new Answer("Я могу работать в кузнице"),
                }),
        };

            Console.WriteLine("Совершенно очевидно, что мы не берём в наш орден кого попало. По этому заполни вот эту анкету, " +
                              "и мы примем решение, брать тебя или нет");


            foreach (var stage in array)
            {
                Console.WriteLine(stage.Question.Text);
                foreach (var stageAnswer in stage.Answers)
                {
                    Console.Write(stageAnswer.Text+" | ");
                }
                Console.WriteLine();
                Console.ReadLine();
                stage.Door.ChangeStage();
            }

            
        }
        
    }
}