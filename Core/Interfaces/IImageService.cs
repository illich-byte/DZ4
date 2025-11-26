using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    // Інтерфейс для керування завантаженням та видаленням зображень
    public interface IImageService
    {
        // Зберігає файл і повертає відносний шлях (наприклад, "duplo/filename.jpg")
        Task<string> SaveImageAsync(IFormFile file);

        // Видаляє файл за його відносним шляхом
        void DeleteImage(string imagePath);
    }
}