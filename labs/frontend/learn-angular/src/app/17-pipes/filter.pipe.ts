import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter',
  pure: false //each data change will rerun the pipe
})
export class FilterPipe implements PipeTransform {

  transform(value: any[], filter: string, propName: string): any {
    if(value.length === 0 || filter === '') return value;

    const resultArr = [];
    for(const item of value) {
      if(item[propName] === filter) resultArr.push(item);
    }
    return resultArr; 
  }

}
