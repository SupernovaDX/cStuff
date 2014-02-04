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
	string op;
	system("CLS");
	cout << anum << " " << aop << " " << anum1 << "=" << ans << endl;

	cin >> num1;
	anum = num1;
	system("CLS");
	cout << anum << " " << aop << " " << anum1 << "=" << ans << endl;

	cin >> op;
	aop = op;
	system("CLS");
	cout << anum << " " << aop << " " << anum1 << "=" << ans << endl;

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
	cout << anum << " " << aop << " " << anum1 << "=" << ans << endl;

}

