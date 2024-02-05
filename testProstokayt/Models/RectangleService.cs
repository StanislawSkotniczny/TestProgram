namespace testProstokayt.Models
{
    public class RectangleService : IRectangleService
    {
        private readonly List<Rectangle> _rectangles = new List<Rectangle>();

        
        public void AddRectangle(Rectangle rectangle)
        {
            rectangle.Id = Guid.NewGuid();
            _rectangles.Add(rectangle);
        }

        
        public IEnumerable<Rectangle> GetRectangles()
        {
            return _rectangles;
        }



       public Rectangle GetRectangleById(Guid id)
        {
            return _rectangles.FirstOrDefault(r => r.Id == id);
        }


        public void DeleteRectangle(Guid id)
        {
            _rectangles.RemoveAll(r => r.Id == id);
        }


        public void UpdateRectangle(Guid id, Rectangle rectangle)
        {
            var index = _rectangles.FindIndex(r => r.Id == id);
            if (index != -1)
            {
                _rectangles[index] = rectangle;
            }
        }
      
    }
}
