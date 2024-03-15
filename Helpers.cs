using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCleaningTemplate
{
        public static class Helpers
        {

            public async static void Balanga(VisualElement obj)
            {
                obj.FadeTo(1, 1000);
                obj.RotateYTo(360, 400);
                obj.ScaleTo(1.5, 400);
                await Task.Delay(400);
                obj.ScaleTo(1, 700);
                obj.RotationY = 0;
        }
        public async static Task Rotate(VisualElement obj)
        {
            obj.RotateYTo(360, 400);
            obj.ScaleTo(1.2, 400);
            await Task.Delay(400);
            obj.ScaleTo(1, 400);
            obj.RotationY = 0;
        }
    }
}
