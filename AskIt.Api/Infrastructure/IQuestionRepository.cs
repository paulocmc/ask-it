using System.Threading.Tasks;
using AskIt.Api.Models;

namespace AskIt.Api.Infrastructure
{
    public interface IQuestionRepository
    {
        Task Save(Question question);
    }
}