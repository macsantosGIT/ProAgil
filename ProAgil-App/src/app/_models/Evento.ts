import { Lote } from './Lote';
import { Palestrante } from './Palestrante';
import { RedeSocial } from './RedeSocial';

export class Evento {

    constructor(){ }

    id: number;
    local: string;
    dataEvento: string;
    tema: string;
    qtdPessoas: number;
    imagemURL: string;
    telefone: string;
    email: string;
    lotes: Lote[];
    redeSociais: RedeSocial[];
    palestrantesEventos: Palestrante[];
}
