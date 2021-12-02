#include <iostream>
#include <string>

using namespace std;

class Manager
{
	private:
		string strName;
		string strDepartment;
		int	intNumEmployees;

	public:
		//Constructor_Destructor
		Manager(void);
		~Manager(void);
		Manager(string, string, int);

		//Mutator
		void setManager (string, string, int);
		string getName (void);
		string getDept (void);
		int getNumEmp (void);
		
};

