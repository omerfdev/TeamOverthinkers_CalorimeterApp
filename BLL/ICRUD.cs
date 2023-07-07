using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public interface ICRUD<T> where T : class
	{
		List<T> GetAll();
		T Search(int id);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
