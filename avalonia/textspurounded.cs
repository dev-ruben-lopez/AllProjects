public override void Render(DrawingContext context)
{
    base.Render(context);

    const string text = "Your Text";
    const float textSize = 24f;

    context.Custom(new CustomDrawOperation(new Rect(Bounds.Size), canvas =>
    {
        using var paint = new SKPaint
        {
            Color = SKColors.White,
            TextSize = textSize,
            IsAntialias = true,
            Typeface = SKTypeface.Default,
        };

        // Measure text bounds
        SKRect textBounds = new();
        paint.MeasureText(text, ref textBounds);

        float padding = 4f; // Padding around the text
        float x = 10; // Left position
        float y = 40; // Baseline Y (adjust as needed)

        float rectLeft = x + textBounds.Left - padding;
        float rectTop = y + textBounds.Top - padding;
        float rectRight = x + textBounds.Right + padding;
        float rectBottom = y + textBounds.Bottom + padding;

        // Draw border rectangle
        using var borderPaint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            StrokeWidth = 1,
            Color = SKColors.White,
            IsAntialias = true
        };

        canvas.DrawRect(
            rectLeft,
            rectTop,
            rectRight - rectLeft,
            rectBottom - rectTop,
            borderPaint);

        // Draw text
        canvas.DrawText(text, x, y, paint);
    }));
}


canvas.DrawRoundRect(
    rectLeft,
    rectTop,
    rectRight - rectLeft,
    rectBottom - rectTop,
    8, 8, // corner radius x, y
    borderPaint);
