// Програма Prog6_7.cpp от лекцията за шаблоните
// Демонстрация на обобщен клас на опашка.
#include <iostream> 
using namespace std;

//const int SIZE=100;
// Създаване на обобщен клас queue, ползващ обобщен тип QType

template <typename QType=int, int size=4> 
class queue {
  QType q[size]; 
  int sloc, rloc; 
  int count;
public:
  queue() { count = sloc = rloc = 0; }
  void qput(QType i);
  QType inputData();
  QType qget();
  void getline();
};
// Поставяме обекта в опашката.
template <typename QType, int size> void queue<QType,size>::qput(QType i){
  if(count == size) {cout << "Опашката е запълнена!\n\n"; return;}
  q[sloc++] = i;
  count++;
  if(sloc == size){sloc=0;}
}
// забележете и <typename QType> и <class QType> са верни !
// Новият клас върви винаги с неговия си тип QType, а за да се
// покаже, че QType е обобщен тип се слага отпред template <typename QType>

template <typename QType, int size> 
QType queue<QType,size>::inputData(){
	cin.sync();
	QType buf;
	cout << "\nВъведете стойност, която да поставим в опашката: ";
	cin >> buf;
	return buf;
}

template <> 
string queue<string, 5>::inputData(){
	cin.sync();
	string buf;
	cout << "\nВъведете низ, която да поставим в опашката: ";
	getline(cin, buf);
	return encode(buf); // ако има кирилица е encode
}

template <typename QType, int size> QType queue<QType,size>::qget(){// Извличане на обекта от опашката.
  if (count==0) {	
    cout << "Опашката е празна!\n"; return 0; 
  }
  count--;
  if(rloc==size){rloc=0;}
  return q[rloc++];
}

//template<typename QType=string, int size=4>void queue<QType,size>::getline(){cin>>buffer>}

int main(){
  setlocale (LC_ALL, "Bulgarian");

  queue<> a; //Създаваме две опашки за цели числа.
  cout << a.qget() << " "<< endl; //опит за четене от празна опашка
//!
 a.qput(a.inputData());
 a.qput(a.inputData());
 a.qput(a.inputData());
  cout << a.qget() << " ";
  cout << a.qget() << " " << endl;
  a.qput(a.inputData());
	a.qput(a.inputData());
	 a.qput(a.inputData());
	a.qput(a.inputData());
   cout << a.qget() << " ";
    cout << a.qget() << " ";
     cout << a.qget() << " ";
      cout << a.qget() << " ";
       cout << a.qget() << " ";
//  queue<double> c, d;// Създаваме две опашки за double-стойности.
 // c.qput(10.12); 
 // d.qput(19.99) ;
 // c.qput(-20.0); 
 // d.qput(0.986) ;
 // cout << c.qget() << " ";
 // cout << c.qget() << " " << endl;
 // cout << d.qget() << " ";
 // cout << d.qget() << "\n\n";
}


