class ArrayCounter {
    public static function main() {
        var evenNumber = [ for (i in 0...100) if (i%2==0) i];

        for(num in evenNumber) {
            trace(num);
        }

    }
}