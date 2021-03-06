﻿using System;

namespace BookApp
{

    class Program
    {

        static void Main()
        {
            Document document = new Document("\n Рекомендуемая книга: Программист-прагматик")
            {
                Body = "\n Kраткое описание:" + "\n Легендарная книга, которую стоит прочитать всем," + " кто связан с программированием и управлением проектами в ИТ."
                       + "\n Здесь описаны наиболее интересные случаи и главные проблемы в разработке," + " с которыми сталкивались авторы." +
                       "\n Быть прагматиком в сфере IT – значит работать эффективно, " + "и данная книга поможет этого добиться.",
                Author = "\n Автор: Эндрю Хант и Дэвид Томас"
            };

            document.Show();

            Console.ReadKey();
        }

    }
}



