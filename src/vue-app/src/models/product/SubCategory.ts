import {Product} from "./Product.ts";

export interface SubCategory {
    id: string;
    name: string;
    products: Product[];
}