#include <bits/stdc++.h>

using namespace std;

typedef long long ll; 

int main()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

   string s;
   cin>> s;

   set<string> l;
   l.insert("ACE");
   l.insert("BDF");
   l.insert("CEG");
   l.insert("DFA");
   l.insert("EGB");
   l.insert("FAC");
   l.insert("GBD");

   if(l.count(s) == 0) cout<<"No"<<endl;
   else cout<<"Yes"<<endl;
}