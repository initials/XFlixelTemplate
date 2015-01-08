using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using org.flixel;

using System.Linq;
using System.Xml.Linq;

namespace XFlixelTemplate
{
    public class IntroState : FlxState
    {

        override public void create()
        {
            FlxG.backColor = Color.Purple;
            base.create();

            FlxSprite testPattern = new FlxSprite(0, 0);
            testPattern.loadGraphic("flixel/diagnostic/checkerboard");
            add(testPattern);

            Logo logo = new Logo(0, 0);
            add(logo);


        }

        override public void update()
        {

            base.update();
        }

        public override void render(SpriteBatch spriteBatch)
        {
            
            base.render(spriteBatch);
        }


    }
}
