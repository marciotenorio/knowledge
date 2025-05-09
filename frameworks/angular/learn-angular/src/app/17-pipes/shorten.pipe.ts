import { Pipe, PipeTransform } from "@angular/core";

@Pipe({
    name: 'shorten'
})
export class ShortenPipe implements PipeTransform {
    transform(value: string, limit: number, strEnd?: string) {
        if(value.length > limit) {
            return value.substring(0, 10) + `${strEnd || '...'}`;
        }
        return value;
    }

}