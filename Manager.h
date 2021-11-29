#include <iostream>
#include <string>

using namespace std;

class Manager
{
private:
	string strFName;
	string strLName;
	string strDepartment;
	string strManName;
	int	intNumEmployees;

public:
	//Constructor_Destructor
	Manager(void);
	~Manager(void);
	Manager(string, string, string, int);

	//Mutator
	void setName (string, string);
	string getName (void);

};

