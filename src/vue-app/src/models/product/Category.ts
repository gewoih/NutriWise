import {SubCategory} from "./SubCategory.ts";

export interface Category {
    id: string;
    name: string;
    subCategories: SubCategory[];
}