import { Genero } from "./genero";

export interface Filme {
  id?: number;
  nome: string;
  ano: number;
  generoId: number;
  genero?: Genero;
 }