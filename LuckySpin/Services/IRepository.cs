using LuckySpin.Models;
namespace LuckySpin.Services
    {
    public interface IRepository{
        public void AddSpin(Spin s);
        public IEnumerable<Spin> getSpins();
    }
}