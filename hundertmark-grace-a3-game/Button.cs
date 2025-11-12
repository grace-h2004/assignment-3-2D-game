using Raylib_cs;
using System;
using System.Numerics;



namespace MohawkGame2D
{
    public class Button
    {
        //button variables
        Vector2 size;
        Vector2 position;
        private string text;

        public Button(Vector2 position, Vector2 size, string text)
        {
            this.position = position;
            this.size = size;
            this.text = text;
        }

        //update game for button
        public void Update()
        {
            drawButton();
        }

        //draws button
        public void drawButton()
        {
            Draw.FillColor = Color.Gray;
            Draw.Rectangle(position, size);
            Text.Size = 30;
            Text.Draw(text, position);
        }

        //if button is clicked
        public bool MouseClick()
        {
            Vector2 mousePosition = Input.GetMousePosition();
            bool buttonPressed = false;
            if (mousePosition.X > position.X && mousePosition.X < position.X + size.X && mousePosition.Y > position.Y && mousePosition.Y < position.Y + size.Y && Input.IsMouseButtonPressed(0))
            {
                buttonPressed = true;
                return buttonPressed;
            }
            else
            {
                return false;
            }
        }
    }
}