#include <bits/stdc++.h>

using namespace std;

int main(int argc, char *argv[]) {
  int n;
  string s;

  cin >> n >> s;

  string lw;

  int t = 0;
  int a = 0;
  for (int i = 0; i < n; ++i) {
    if (s[i] == 'T')
      ++t;
    else
      ++a;
    lw = s[i];
  }

  if (t > a)
    cout << "T" << endl;
  else if (a > t)
    cout << "A" << endl;
  else if (lw == "T")
    cout << "A" << endl;
  else
    cout << "T" << endl;

  return 0;
}
