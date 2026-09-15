// Програма Prog6_7.cpp от лекцията за шаблоните
// Демонстрация на обобщен клас на опашка.
#include <iostream> 
using namespace std;

//const int SIZE=100;
// Създаване на обобщен клас queue, ползващ обобщен тип QType
template <typename QType, int size> 
class queue {
  QType q[size]; 
  int sloc, rloc; 
public:
  queue() { sloc = rloc = 0; }
  void qput(QType i);
  QType qget();
};
// Поставяме обекта в опашката.
template <typename QType, int size> void queue<QType, size>::qput(QType i){
  if(sloc == size) {cout << "Опашката е запълнена!\n\n"; return;}
  q[sloc++] = i;
}
// забележете и <typename QType> и <class QType> са верни !
// Новият клас върви винаги с неговия си тип QType, а за да се
// покаже, че QType е обобщен тип се слага отпред template <typename QType>
template <typename QType, int size> QType queue<QType, size>::qget(){// Извличане на обекта от опашката.
  if (rloc == sloc) {	
    cout << "Опашката е празна!\n"; return 0; 
  }
  return q[rloc++];
}
int main(){
  setlocale (LC_ALL, "Bulgarian");

  queue<int,5> a; //Създаваме две опашки за цели числа.
  cout << a.qget() << " "<< endl; //опит за четене от празна опашка

  a.qput(10); 
  a.qput(20); 
  a.qput(15);
  cout << a.qget() << " ";
  cout << a.qget() << " " << endl;
  a.qput(25); 
  a.qput(30);
  //queue<double> c, d;// Създаваме две опашки за double-стойности.
  //c.qput(10.12); 
  //d.qput(19.99) ;
  //c.qput(-20.0); 
  //d.qput(0.986) ;
  //cout << c.qget() << " ";
  //cout << c.qget() << " " << endl;
  //cout << d.qget() << " ";
  //cout << d.qget() << "\n\n";
}


