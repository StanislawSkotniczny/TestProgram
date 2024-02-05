namespace testProstokayt.Models
{
    public interface IRectangleService
    {
        void AddRectangle(Rectangle rectangle);
        IEnumerable<Rectangle> GetRectangles();

        Rectangle GetRectangleById(Guid id);


        void UpdateRectangle(Guid id, Rectangle rectangle);
        void DeleteRectangle(Guid id);

    }
}
