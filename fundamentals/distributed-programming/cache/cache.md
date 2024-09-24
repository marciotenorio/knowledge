# Cache 

## Summary

- [. . /Distributed Programming](../dp.md)
  

## Main Concerns

1. Handle side effects
2. Inconsistent data in cache
3. Low performance in cache

How to calculate the request time in cache-aside strategy:
> request_time = cache_check + service_call_time_ + cache_write

- Cache hit: when the data exists in cache
- Cache miss: when the data doesn't exists in cache

Cache effectiveness: 
> cache_check < service_call_time
> cache hit > cache miss

How to calculate the hit rate:
> hit_rate = (cache_hit / (cache_hit + cache_miss)) * 100

Caches initializations: warm and cold. 

Cache strategies:
- Inline cache:
  - Between "request" and data storage. This approach the cache are first accessed then the cache write in the database (synchronous).
- Cache-aside patterns:
  - Don't access the data storage, the cache consistency it's your concern.
- Cache consistency:
  - Invalidation
  - Write-through - application update the cache and cache update the data storage
(synchronous)
  - Write-behind/write-back - application update the cache and return. Later the
cache update the data storage (async)
- Cache eviction:
  - LRU - Least Recently Used
  - MRU - Most Recently Used
  - LFU - Least Frequently Used
  - TTL - Time To Live
  - Random - Used when you can't predict the access distribution


