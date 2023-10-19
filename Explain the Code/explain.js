function binarySearch(arr: any[], key: any){
    let low = 0;
    let high = arr.length - 1;
    while (low <= high){
        const mid = Math.floor((low + high) / 2);
        const guess = arr[mid];
        if(guess === key) return mid;
        if(guess > key) high = mid - 1;
        else low = mid + 1;
    }
    return -1;
}