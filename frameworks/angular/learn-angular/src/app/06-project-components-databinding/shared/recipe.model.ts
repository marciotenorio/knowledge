import { Ingredient } from "./ingredient.model";

export class Recipe {
    constructor(public name: string, 
        public ingredients: Array<Ingredient>,
        public imgUrl: string) {}
}