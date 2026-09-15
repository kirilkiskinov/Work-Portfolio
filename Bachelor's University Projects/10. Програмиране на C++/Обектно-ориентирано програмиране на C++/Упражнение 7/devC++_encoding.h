// Преобразуване от кодировката на devC++ към
// кодировката на cmd (command line window)
#include <iostream> 
#include <string.h> 
#include <vector> 
using namespace std;
// прототипи- prototypes
double encode(double d);
char encode(char c);// the basic function
char* encode(char *s);
string& encode(string& s);
vector<char> encode(vector<char> v);
	
double 	encode(double d){
	return d;
}
char encode(char c){
  	switch (c) { 
// Capital Cyrillic letters
   	case '\200': c = 'А'; break;
   	case '\201': c = 'Б'; break;
   	case '\202': c = 'В'; break;
   	case '\203': c = 'Г'; break;
   	case '\204': c = 'Д'; break;
   	case '\205': c = 'Е'; break;
   	case '\206': c = 'Ж'; break;
   	case '\207': c = 'З'; break;
   	case '\210': c = 'И'; break;
   	case '\211': c = 'Й'; break;
   	case '\212': c = 'К'; break;
   	case '\213': c = 'Л'; break;
   	case '\214': c = 'М'; break;
   	case '\215': c = 'Н'; break;
   	case '\216': c = 'О'; break;
   	case '\217': c = 'П'; break;
   	case '\220': c = 'Р'; break;
   	case '\221': c = 'С'; break;
   	case '\222': c = 'Т'; break;
   	case '\223': c = 'У'; break;
   	case '\224': c = 'Ф'; break;
   	case '\225': c = 'Х'; break;
   	case '\226': c = 'Ц'; break;
   	case '\227': c = 'Ч'; break;
  	case '\230': c = 'Ш'; break;
   	case '\231': c = 'Щ'; break;
   	case '\232': c = 'Ъ'; break;
	case '\233': c = 'Ы'; break;
   	case '\234': c = 'Ь'; break;
	case '\235': c = 'Э'; break;
   	case '\236': c = 'Ю'; break;
   	case '\237': c = 'Я'; break;
// small Cyrillic letters	
  	case '\240': c = 'а'; break;
   	case '\241': c = 'б'; break;
   	case '\242': c = 'в'; break;
   	case '\243': c = 'г'; break;
   	case '\244': c = 'д'; break;
   	case '\245': c = 'е'; break;
   	case '\246': c = 'ж'; break;
   	case '\247': c = 'з'; break;
   	case '\250': c = 'и'; break;
   	case '\251': c = 'й'; break;
   	case '\252': c = 'к'; break;
   	case '\253': c = 'л'; break;
   	case '\254': c = 'м'; break;
   	case '\255': c = 'н'; break;
   	case '\256': c = 'о'; break;
   	case '\257': c = 'п'; break;
   	case '\340': c = 'р'; break;
   	case '\341': c = 'с'; break;
   	case '\342': c = 'т'; break;
   	case '\343': c = 'у'; break;
   	case '\344': c = 'ф'; break;
   	case '\345': c = 'х'; break;
   	case '\346': c = 'ц'; break;
   	case '\347': c = 'ч'; break;
  	case '\350': c = 'ш'; break;
   	case '\351': c = 'щ'; break;
   	case '\352': c = 'ъ'; break;
  	case '\353': c = 'ы'; break;
   	case '\354': c = 'ь'; break;
	case '\355': c = 'э'; break;
   	case '\356': c = 'ю'; break;
   	case '\357': c = 'я'; break;
// special (rare used) Russian letters
	case '\360': c = 'Ё'; break;
	case '\361': c = 'ё'; break;
	} // switch
	return c;
 }
 
char* encode(char *s){
  for (unsigned int i = 0;i < strlen(s);i++){
  	s[i] = encode(s[i]);
  }
  return s;
}// encode()

string& encode(string& s){
  for (unsigned int i=0; i<s.size(); i++){
  	s[i] = encode(s[i]);
  }
  return s;
}// encode()

vector<char> encode(vector<char> v){
  for (unsigned int i=0; i < v.size(); i++){
  	v[i] = encode(v[i]);
  }
  return v;
}

