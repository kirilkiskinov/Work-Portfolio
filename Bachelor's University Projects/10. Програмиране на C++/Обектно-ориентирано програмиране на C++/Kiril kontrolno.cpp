// Програма Prog8_19.cpp
// Използване на презареден оператор за вход-изход за 
// запис на обекти от класа three_d във файл с име threed. 
#include <iostream>
#include <fstream> 
using namespace std;

class three_d {
  //int x, y, z; // 3-мерни координати;  
public:
  int x, y, z;
  three_d(int a, int b, int c) { x = a; y = b; z = c; }
  three_d() { x = 0; y = 0; z = 0; }
  void myfun(){ cout << "x = "<< x << endl; } 
  friend ostream& operator<<(ostream& stream, three_d obj);
  friend istream& operator>>(istream& stream, three_d & obj);
};
// Извежда координатите X, Y, Z 
// (оператор за извеждане за класа three_d)
ostream& operator<<(ostream& stream, three_d obj) {
  stream << obj.x << ", "; 
  stream << obj.y << ", "; 
  stream << obj.z << "\n"; 
  return stream; // връща поток
}

istream& operator>>(istream& stream, three_d &obj){
  stream >> obj.x;
  stream.get();
  stream >> obj.y;
  stream.get();
  stream >> obj.z; 
  return stream;
}

int main(){
  setlocale (LC_ALL, "Bulgarian");
  three_d a(1, 2, 3), b(6, 7, 8), c(10, 11, 13); 
  three_d m[3];
  three_d* p = m;
  ofstream out1("threed");
  ofstream out2("mythreed");
  if(!out2) {
	cout << "Файлът mythreed не може да се отвори.\n";  
	return 1;
  }
  if(!out1) {
	cout << "Файлът не може да се отвори.\n";  
	return 1;
  }
  out2.write((char*)&a, sizeof a);
  out2.write((char*)&b, sizeof a);
  out2.write((char*)&c, sizeof a);
  out1 << a << b << c; 
  out1.close(); 
  out2.close(); 
  ifstream in1("mythreed");
  if(!in1) {
	cout << "Файлът mythreed не може да се отвори за четене.\n";  
	return 1;
  }
  cout << m[0] << m[1] << m[2] ;
  
  cout << "sizeof a = " << sizeof a << endl;
  for (unsigned int i = 0; i < 3; i++){
  	in1.read((char*)p++, sizeof a);
  }
  cout << m[0] << m[1] << m[2] ;
  m[0] = m[1] = m[2] = {};
   cout << m[0] << m[1] << m[2] ;
  m[1].myfun();
  in1.close();
  
  ifstream in2("threed");
  if(!in2) {
	cout << "Файлът mythreed не може да се отвори за четене.\n";  
	return 1;
  }

  in2 >> m[0] >> m[1] >> m[2]; 
  cout << m[0] << m[1] << m[2] ; 
}
