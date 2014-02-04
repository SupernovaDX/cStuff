#include <iostream>
#include <string>

using namespace std;

double anum, anum1, ans;
string  aop;
double add(double num1, double num2){
	return num1 + num2;
}
double sub(double num1, double num2){
	return num1 - num2;
}
double mult(double num1, double num2){
	return num1 * num2;
}
double div(double num1, double num2){
	return num1 / num2;
}
int main(){
	double num1, num2, answer;
	aop = "#";
	anum = 0;
	anum1 = 0;
	answer = 0;
	string op;
	system("CLS");
	cout << anum << " " << aop << " " << anum1 << "=" << answer << endl;

	cin >> num1;
	anum = num1;
	system("CLS");
	cout << anum << " " << aop << " " << anum1 << "=" << answer << endl;

	cin >> op;
	aop = op;
	system("CLS");
	cout << anum << " " << aop << " " << anum1 << "=" << answer << endl;

	cin >> num2;
	anum1 = num2;
	if (op == "+"){
		answer = add(num1, num2);
	}
	if (op == "-"){
		answer = sub(num1, num2);
	}
	if (op == "*" || op == "x"){
		answer = mult(num1, num2);
	}
	if (op == "/"){
		answer = div(num1, num2);
	}
	system("CLS");
	cout << anum << " " << aop << " " << anum1 << "=" << answer << endl;
	cout << "Press any Key to Restart" << endl;
	int restart;
	cin >> restart;
	main();
}

