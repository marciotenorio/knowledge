#include <bits/stdc++.h>
#include <chrono>

using namespace std;
using namespace std::chrono;

int main(int argc, char const *argv[])
{
    vector<int> v(1'000'000, 0);

    auto start = high_resolution_clock::now();

    int in;
    for (size_t j = 0; j < 2; j++)
    {
        for (int i = 0; i < 1'000'000; i++)
        {
            cin >> in;
            v[i] = in;
        }

    }

    auto end = high_resolution_clock::now();
    
    auto duration = duration_cast<milliseconds>(end-start);
    cout << "Total: " << duration.count() << " ms" << endl;

    return 0;
}
