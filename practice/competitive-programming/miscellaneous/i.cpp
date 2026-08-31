#include <bits/stdc++.h>

using namespace std;
typedef long long ll;

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(nullptr);

  int n;
  cin >> n;

  set<int> s;
  for (int i = 0; i < n; i++) {
    int in;
    cin >> in;
    s.insert(in);
  }

  if (s.size() == n)
    cout << "YES" << endl;
  else
    cout << "NO" << endl;

  return 0;
}
