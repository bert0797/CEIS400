#include <iostream>
#include <string.h>
#include "Manager.h"

using namespace std;


class Technician :
	public Manager
{
private:
	string strFName;
	string strLName;
	string strDepartment;
	double dblEmployeeNumber;
	Manager manName;

public:
	//Constructor_Destructor
	Technician(void);
	~Technician(void);
	Technician(string,string, double);

	//Mutator
	void setName (string, string);
	string getName (void);






};

