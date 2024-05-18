import { Injectable } from "@angular/core";

@Injectable()  //is a good practice, but can be omitted
export class LoggingService {
    logStatusChange(status: string) {
        console.log('A server status changed, new status: ' + status);
        
    }
}