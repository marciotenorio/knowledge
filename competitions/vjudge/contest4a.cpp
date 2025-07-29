#include <bits/stdc++.h>

using namespace std;

typedef long long ll;

int main() {
  ios_base::sync_with_stdio(0);
  cin.tie(0);

  int l;
  string n;

  cin >> l;
  cin >> n;

  string ans;

  for (int i = 0; i < l; ++i) {
    ans += n[i];
    ans += n[i];
  }

  cout << ans << endl;
}
