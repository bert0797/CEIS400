#include <iostream>
#include <string.h>

using namespace std;

class Technician
{
private:
	string strDepartment;
	string strName;
	double dblEmployeeNumber;
	//Manager manName;

public:
	//Constructor_Destructor
	Technician(void);
	~Technician(void);
	Technician(string, double);

	//Mutator
	void setEmployee (string, double);
	string getName (void);
	void setEmpNum (double);
	double getEmpNum (void);

	
};

