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
int check(){
	int value(0);
	while (!(cin >> value)) {
		std::cout << "you entered a non-digit character\n";
		std::cin.clear();   // make sure that std::cin is happy to do something
		std::cin.ignore();  // ignore the offending character
	}
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
	check();
	anum = num1;
	system("CLS");
	cout << anum << " " << aop << " " << anum1 << "=" << answer << endl;

	cin >> op;
	aop = op;
	system("CLS");
	cout << anum << " " << aop << " " << anum1 << "=" << answer << endl;

	cin >> num2;
	check();
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
	string restart;
	cin >> restart;
	main();
}

