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
        cout << "����: " << m_name <<"\t" <<"ѧ��: " << m_id << endl;
    }
    Student() {
        cout << "���캯��\t";
    }
    ~Student() {
        cout << "��������\t";
    }
};

int main() {
    Student s1;
    s1.writename("����");
    s1.writeid(12341);
    s1.PrintStudent();
}