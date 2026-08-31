import { AbstractControl, ValidationErrors, ValidatorFn } from "@angular/forms";

export function forbiddenText(textRegExp: RegExp): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
        const forbidden = textRegExp.test(control.value);
        return forbidden ? { forbiddenText: { value: control.value} } : null;
    }
}