#include <iostream> // Nashata goliama programa
#include <cstring>
#include <cstdlib>
#include <iomanip>
#include <cmath>
#include <ctime>
#include <time.h>
using namespace std;

const int N = 100;
const int Year = 2020;
const int Num_of_meseci = 12;
enum kategorii {ipoteka=1, zastrahovka, danuk, parno, voda,
   tok, remont, drugo} ;

struct dohod {
  unsigned int apartament;
  unsigned int cena;
  char naematel[50];
  unsigned int naemi[Num_of_meseci];
};

struct razhod {
  char poluchatel[50];
  double suma;
  kategorii kategoriq;
  time_t data;
};

typedef dohod dohod_t;
typedef razhod razhod_t;

int findNumberOfElements(dohod *p);
int findNumberOfElements(razhod *p);
void init_list(dohod_t* ps, unsigned int startIndex);
void init_list(razhod_t* ps, unsigned int startIndex);
void printVsichkiDohodi (dohod *p);
void printVsichkiRazhodi (razhod *p);
void printOneDohod (dohod_t* ps);
void printOneRazhod (razhod_t* ps);
char printMenu();
void dobaviNaematel(dohod *p, unsigned int numOfElements);
void vavediNaematel(dohod *p);
void dobaviNaem(dohod *p, unsigned int suma, unsigned int numOfElements);
void vavediNaem(dohod *p);
void dobaviRazhod(razhod *p, unsigned int numOfElements);
void vavediRazhod(razhod *p);
void printRazhodPoKategoriq (razhod *p);

int findNumberOfElements(dohod *p){
	int i;
	for(i=0; i<N; i++){// tyrsim pyrvia svoboden element
		if ( !p[i].apartament) break;
	}
	return i;
}

int findNumberOfElements(razhod *p){
	int i;
	for(i=0; i<N; i++){// tyrsim pyrvia svoboden element
		if ( !p[i].poluchatel[0]) break;
	}
	return i;
}

void init_list(dohod_t* ps, unsigned int startIndex){// inicializacia na masiva
	for(int t=startIndex; t<N; t++) {ps[t].naematel[0] ='\0';}
}

void init_list(razhod_t* ps, unsigned int startIndex){// inicializacia na masiva
	for(int t=startIndex; t<N; t++) {ps[t].poluchatel[0] ='\0';}
}

void printVsichkiDohodi (dohod *p) {
	cout << flush;
	for (int i=0;i<N;++i){
		if ((p+i)->apartament){
			printOneDohod (p+i);
		 	cin.sync();
			getchar();
//			system("Pause");
		}
	}
}

void printVsichkiRazhodi (razhod *p) {
	cout << flush;
	for (int i=0;i<N;++i){
		if ((p+i)->poluchatel[0]){
			printOneRazhod (p+i);
		 	cin.sync();
			getchar();
//			system("Pause");
		}
	}
}

void printOneDohod (dohod_t* ps){
  cout << "Apartament: " << ps->apartament;
  cout << "\nCena: " << ps->cena;
  if (ps->naematel[0]){
    cout << "\nNaematel: " <<ps->naematel;
  }
  cout << "\nNaemi: ";
  for (int i=0; i<Num_of_meseci; i++){
    if (ps->naemi[i] != 0){
  	    cout << i+1 << ":" << ps->naemi[i] << " ";
    }
  }
  cout << '\n';
  return;
}

void printOneRazhod (razhod_t* ps){
  cout << "Poluchatel: " << ps->poluchatel;
  cout << "\nSuma: " <<ps->suma;
  cout <<"\nSpecialnost:  ";
	switch (ps->kategoriq) {
		case ipoteka: cout << "Ipoteka\n";
		  break;
		case zastrahovka : cout << "Zastrahovka\n";
		  break;
		case danuk:  cout << "Danuk\n";
  		  break;
		case voda: cout << "Voda\n";
 		  break;
		case tok: cout << "Tok\n";
 		  break;
		case remont: cout << "Remont\n";
 		  break;
		case drugo: cout << "Drugo\n";
 		  break;
		default:    cout << "Neizvestna\n";
		  break;
	}
  cout <<"Data:  "<<asctime(localtime ( &ps->data ))<<"\n";
	return;
}

char printMenu(){
  char c;
  do {
   system("cls");
   cout <<"1. Izvejdane na prihodi\n";
   cout <<"2. Izvejdane na razhodi\n";
   cout <<"3. Dobavqne na namematel\n";
   cout <<"4. Plashtane na naem\n";
   cout <<"5. Dobavqne na razhod\n";
   cout <<"6. Izvejdane na razhodi po kategoriq\n";
   cout <<"0. Krai na programata\n\n";
   cout <<"Vashiat izbor: ";
   cin >> c;
  }while (c<'0' || c > '9');
  cout << endl;
  return c;
}

void dobaviNaematel(dohod *p, unsigned int numOfElements){
  unsigned int i, ap;
	char buffer[32];
	cin.sync();
	do {
		cout << "Nomer na apartament (cialo 3 cifreno + chislo): ";
		gets(buffer);
		ap = atoi(buffer);
	}while (ap <=0 || ap >= 1000);
	for (i=0;i<numOfElements;i++){
		if ((p+i)->apartament == ap){
      if((p+i)->naematel[0]){
        cout << "Apartamentut veche ima naematel\n";
        getchar();
        return;
      }
      else{
  			cout << "\nShte se vavedat novi danni za:\n\n";
  			printOneDohod (p+i);
  			cout << "\n";
  			vavediNaematel(p+i);
  			return;
      }
		}
	}
	cout << "Ne e otkrit apartament " << ap << endl;
	getchar();
}

void vavediNaematel(dohod *p){
  char buffer[32];
  unsigned int i, mesec;
  bool stop;
  cin.sync();
  do {
    stop = false;
    cout << "Naematel: ";
    gets(p->naematel);
    if (strlen(p->naematel) > 1){
      for (i=0;i<strlen(p->naematel); i++){
        if (!isalpha(p->naematel[i])){
          stop = true;
          break;
        }
      }
    }
  } while ((strlen(p->naematel) < 2) || stop);
  do {
    cout << "Mesec na naemane: ";
    gets(buffer);
		mesec = atoi(buffer);
	}while (mesec <=0 || mesec > 12);
  for (i=0;i < mesec - 1; i++){
    p->naemi[i] = 0;
  }
  p->naemi[mesec - 1] = p->cena;
}

void dobaviNaem(dohod *p, unsigned int numOfElements){
  unsigned int i;
	char buffer[32];
  char naematel[50];
  bool stop;
	cin.sync();
  do {
    do {
      stop = false;
      cout << "Naematel: ";
      gets(naematel);
      //gets(naematel);
      if (strlen(naematel) > 1){
        for (i=0;i<strlen(naematel); i++){
          if (!isalpha(naematel[i])){
            stop = true;
            break;
          }
        }
      }
      else{
          return;
      }
    } while (strlen(naematel) < 2);
    stop = true;
  	for (i=0;i<numOfElements;i++){
  		if (strcmp((p+i)->naematel, naematel) == 0){
        stop = false;
        vavediNaem(p+i);
        return;
  		}
  	}
  	cout << "Ne e otkrit naematel" << naematel << endl;
  } while(naematel[0] && stop);
  getchar();
}

void vavediNaem(dohod *p){
  char buffer[32];
  unsigned int broi_naemi, i, j, suma;
  bool ima_plashtane;
  cin.sync();
  cout << "Suma: ";
  gets(buffer);
  suma = atoi(buffer);
  broi_naemi = suma / p->cena;
  for (i=0;i < Num_of_meseci; i++){
    if (p->naemi[i] > 0){
      ima_plashtane = true;
    }
    else{
      if (ima_plashtane){
        for (j=i; j < i + broi_naemi; j++){
          if (j >= Num_of_meseci){
            break;
          }
          p->naemi[j] = p->cena;
        }
        break;
      }
    }
  }
}

void dobaviRazhod(razhod *p, unsigned int numOfElements){
	if (numOfElements==N) {
		cout << "Masivyt e pylen!\nNe mojem da dobaviame novi danni.\n";
		cin.sync(); getchar();
	}
	vavediRazhod(p+numOfElements);
}

void vavediRazhod(razhod *p){
  char buffer[32];
  unsigned int i, suma, k;
  bool stop;
  cin.sync();
  do {
    stop = false;
    cout << "Poluchatel: ";
    gets(p->poluchatel);
    if (strlen(p->poluchatel) > 1){
      for (i=0;i<strlen(p->poluchatel); i++){
        if (!isalpha(p->poluchatel[i])){
          stop = true;
          break;
        }
      }
    }
  } while ((strlen(p->poluchatel) < 2) || stop);

  cout << "Suma: ";
  gets(buffer);
	p->suma = atoi(buffer);

  cout << "\nIzbrete chislo syotwetstvashto na kategoria.\n\n";
	for (i = ipoteka;i <= drugo; i++){
		switch (i) {
			case ipoteka: cout << "Ipoteka\t    ";
			  break;
			case zastrahovka : cout << "Zastrahovka\t    ";
			  break;
			case danuk:  cout << "Danuk\t    ";
	  		  break;
			case parno: cout << "Parno\t    ";
	 		  break;
			case voda: cout << "Voda";
	 		  break;
			case tok: cout << "Tok\t    ";
	 		  break;
			case remont: cout << "Remont\t    ";
	 		  break;
			case drugo: cout << "Drugo\t    ";
			  break;
		}
		cout <<" - "<<i<<"\n";
	}// za da se vidiat stoinostite
	do {
		cout <<"\nKategoria =";
		gets(buffer);
		k = atoi(buffer);
	}while (k<=0 || k > drugo);
	p->kategoriq = (kategorii)(k);

  time_t rawtime;
  struct tm * timeinfo;
  int month ,day;

  /* prompt user for date */
  printf ("Vuvedete den: "); fflush(stdout); scanf ("%d",&day);
  printf ("Vuvedete mesec: "); fflush(stdout); scanf ("%d",&month);

  /* get current timeinfo and modify it to the user's choice */
  time ( &rawtime );
  timeinfo = localtime ( &rawtime );
  timeinfo->tm_year = Year - 1900;
  timeinfo->tm_mon = month - 1;
  timeinfo->tm_mday = day;
  p->data = mktime ( timeinfo );
}

void printRazhodPoKategoriq (razhod *p){
  unsigned int kategoriq, k, i;
  char buffer[32];
  time_t data;
  cout << "\nIzbrete chislo syotwetstvashto na kategoria.\n\n";
	for (i = ipoteka;i <= drugo; i++){
		switch (i) {
			case ipoteka: cout << "Ipoteka\t    ";
			  break;
			case zastrahovka : cout << "Zastrahovka\t    ";
			  break;
			case danuk:  cout << "Danuk\t    ";
	  		  break;
			case parno: cout << "Parno\t    ";
	 		  break;
			case voda: cout << "Voda";
	 		  break;
			case tok: cout << "Tok\t    ";
	 		  break;
			case remont: cout << "Remont\t    ";
	 		  break;
			case drugo: cout << "Drugo\t    ";
			  break;
		}
		cout <<" - "<<i<<"\n";
	}// za da se vidiat stoinostite
	do {
		cout <<"\nKategoria =";
		gets(buffer);
		k = atoi(buffer);
	}while (k<=0 || k > drugo);
	kategoriq = (kategorii)(k);

  time_t rawtime;
  struct tm * timeinfo;
  int month ,day;

  /* prompt user for date */
  printf ("Vuvedete den: "); fflush(stdout); scanf ("%d",&day);
  printf ("Vuvedete mesec: "); fflush(stdout); scanf ("%d",&month);

  /* get current timeinfo and modify it to the user's choice */
  time ( &rawtime );
  timeinfo = localtime ( &rawtime );
  timeinfo->tm_year = Year - 1900;
  timeinfo->tm_mon = month - 1;
  timeinfo->tm_mday = day;
  data = mktime ( timeinfo );

  for (int i=0;i<N;++i){
		if ((p+i)->poluchatel[0]){
      if ((p+i)->kategoriq == kategoriq &&
        (p+i)->data < data){
  			printOneRazhod (p+i);
  		 	cin.sync();
  			getchar();
      }
		}
	}
}

int main (){
	char ch;
	dohod *d2;
  razhod *r2;
	dohod dohodi[N] = {
	    {101, 300},
        {102, 250},
        {103, 350},
        {201, 280},
        {202, 280},
        {203, 280},
        {301, 320},
        {302, 300},
        {303, 270},
        {401, 290},
        {402, 320},
        {403, 400}
	};
  time_t rawtime;
  time ( &rawtime );
  razhod razhodi[N] = {
	    {"Dsk", 300, zastrahovka, rawtime},
      {"Obshtina", 250, danuk, rawtime},
      {"Baj Ivan", 150, remont, rawtime},
      {"Toplofikaciq", 180, parno, rawtime},
	};

	int numOfDohodi = findNumberOfElements(dohodi);
	init_list(dohodi, numOfDohodi);

	do {
		d2 = dohodi;
    r2 = razhodi;
		ch = printMenu();
		switch (ch) {
    		case '1': printVsichkiDohodi (dohodi);
    				  break;
        case '2': printVsichkiRazhodi (razhodi);
              break;
    		case '3': dobaviNaematel (d2, numOfDohodi);
    				  break;
    		case '4': dobaviNaem (d2, numOfDohodi);
    				  break;
        case '5': dobaviRazhod (r2, findNumberOfElements(razhodi));
    				  break;
        case '6': printRazhodPoKategoriq (r2);
    				  break;
		}
	} while (ch !='0');
	return 0;
}
