class addressInBg{ 
	string name; 
	string street; 
	string city; 
    string region; 
	string zip;
public:
	addressInBg(string nameArg = "Румен Радев",  
		string streetArg = "бул. \"Княз Ал. Дондуков\" 2",
		string cityArg = "София", 
		string regionArg = "София", 
		string zipArg = "1000") : name(nameArg), street(streetArg),
		  city(cityArg), region(regionArg), zip(zipArg) {}
		  
	string getName(){return name;}
	string getStreet(){return street;}
	string getCity(){return city;}
	string getRegion(){return region;}
	string getZip(){return zip;}
	
	void setName(string nameArg){ name = nameArg;}
	void setStreet(string streetArg){ street = streetArg;}
	void setCity(string cityArg){ city = cityArg;}
	void setRegion(string regionArg){ region = regionArg;}
	void setZip(string zipArg){ zip = zipArg;}
};

