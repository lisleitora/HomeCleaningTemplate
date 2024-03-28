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
        public async static Task Rotate(VisualElement obj,bool isRight)
        {
            obj.RotateYTo(isRight ?360:-360, 400);
            obj.ScaleTo(1.2, 400);
            await Task.Delay(800).ConfigureAwait(true);
            obj.ScaleTo(1, 400);
            obj.RotationY = 0;
        }
        public async static Task Shrink(VisualElement obj, VisualElement obj2, bool isRight)
        {
            obj.RotateXTo(isRight ? 360 : -360, 600);
            obj.ScaleTo(0, 600);
            await Task.Delay(800).ConfigureAwait(true);
            obj.IsVisible = false;
            obj2.IsVisible = true;
            obj.RotationX = 0;
        }
        public async static Task Expand(VisualElement obj, VisualElement obj2, bool isRight)
        {
            obj.IsVisible = true;
            obj.RotateXTo(isRight ? 360 : -360, 600);
            obj.ScaleTo(1.1, 600);
            await Task.Delay(800).ConfigureAwait(true);
            obj.ScaleTo(1, 400);
            obj.RotationX = 0;
            obj2.IsVisible= false;
        }
        public async static Task BoingAppearUp(VisualElement obj, bool isRight)
        {
            obj.TranslateTo(0,0,400,Easing.BounceOut);
           // await Task.Delay(500).ConfigureAwait(true);
           
        }
        public async static Task AppearRight(VisualElement obj, bool isRight)
        {
            obj.TranslateTo(0, 0, 400, Easing.SinOut);
            // await Task.Delay(500).ConfigureAwait(true);

        }
    }
}
