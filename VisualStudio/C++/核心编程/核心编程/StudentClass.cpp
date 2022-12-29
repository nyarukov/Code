#include <iostream>
#include <string>
using namespace std;

class Student {
private:
    string m_name;
    int m_id;
public:
    void writename(string name) {
        m_name = name;
    }
    void writeid(int id) {
        m_id = id;
    }
    void PrintStudent() {
        cout << "姓名: " << m_name <<"\t" <<"学号: " << m_id << endl;
    }
    Student() {
        cout << "构造函数\t";
    }
    ~Student() {
        cout << "析构函数\t";
    }
};

int main() {
    Student s1;
    s1.writename("张三");
    s1.writeid(12341);
    s1.PrintStudent();
}